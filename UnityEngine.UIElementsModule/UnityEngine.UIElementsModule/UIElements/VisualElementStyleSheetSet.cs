using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000232 RID: 562
	public sealed class VisualElementStyleSheetSet : ValueType
	{
		// Token: 0x06002992 RID: 10642 RVA: 0x000B5C10 File Offset: 0x000B3E10
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementStyleSheetSet()
		{
			Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementStyleSheetSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr);
			VisualElementStyleSheetSet.NativeFieldInfoPtr_m_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr, "m_Element");
			VisualElementStyleSheetSet.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr, 100669542);
			VisualElementStyleSheetSet.NativeMethodInfoPtr_Add_Public_Void_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr, 100669543);
			VisualElementStyleSheetSet.NativeMethodInfoPtr_Remove_Public_Boolean_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr, 100669544);
			VisualElementStyleSheetSet.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisualElementStyleSheetSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr, 100669545);
			VisualElementStyleSheetSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr, 100669546);
			VisualElementStyleSheetSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr, 100669547);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000B5CCC File Offset: 0x000B3ECC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElementStyleSheetSet(VisualElement element)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementStyleSheetSet.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000B5D1C File Offset: 0x000B3F1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346724, RefRangeEnd = 346727, XrefRangeStart = 346714, XrefRangeEnd = 346724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(StyleSheet styleSheet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(styleSheet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementStyleSheetSet.NativeMethodInfoPtr_Add_Public_Void_StyleSheet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000B5D64 File Offset: 0x000B3F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346737, RefRangeEnd = 346738, XrefRangeStart = 346727, XrefRangeEnd = 346737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(StyleSheet styleSheet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(styleSheet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementStyleSheetSet.NativeMethodInfoPtr_Remove_Public_Boolean_StyleSheet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000B5DB8 File Offset: 0x000B3FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(VisualElementStyleSheetSet other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementStyleSheetSet.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisualElementStyleSheetSet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000B5E10 File Offset: 0x000B4010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346738, XrefRangeEnd = 346742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementStyleSheetSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000B5E64 File Offset: 0x000B4064
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementStyleSheetSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00010BC6 File Offset: 0x0000EDC6
		public VisualElementStyleSheetSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00010BCF File Offset: 0x0000EDCF
		public VisualElementStyleSheetSet()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementStyleSheetSet>.NativeClassPtr))
		{
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x000B5EA8 File Offset: 0x000B40A8
		// (set) Token: 0x0600299C RID: 10652 RVA: 0x00010BE1 File Offset: 0x0000EDE1
		public unsafe VisualElement m_Element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementStyleSheetSet.NativeFieldInfoPtr_m_Element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementStyleSheetSet.NativeFieldInfoPtr_m_Element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x000B5ED8 File Offset: 0x000B40D8
		public void Clear()
		{
			bool flag = this.m_Element.styleSheetList == null;
			if (!flag)
			{
				this.m_Element.styleSheetList = null;
				this.m_Element.IncrementVersion(VersionChangeType.StyleSheet);
			}
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000B5F14 File Offset: 0x000B4114
		public void Swap(StyleSheet old, StyleSheet @new)
		{
			bool flag = old == null;
			if (flag)
			{
				throw new ArgumentNullException("old");
			}
			bool flag2 = @new == null;
			if (flag2)
			{
				throw new ArgumentNullException("new");
			}
			bool flag3 = this.m_Element.styleSheetList == null;
			if (!flag3)
			{
				int num = this.m_Element.styleSheetList.IndexOf(old);
				bool flag4 = num >= 0;
				if (flag4)
				{
					this.m_Element.IncrementVersion(VersionChangeType.StyleSheet);
					this.m_Element.styleSheetList[num] = @new;
				}
			}
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000B5FA8 File Offset: 0x000B41A8
		public bool Contains(StyleSheet styleSheet)
		{
			bool flag = styleSheet == null;
			if (flag)
			{
				throw new ArgumentNullException("styleSheet");
			}
			bool flag2 = this.m_Element.styleSheetList != null;
			return flag2 && this.m_Element.styleSheetList.Contains(styleSheet);
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000B5FF8 File Offset: 0x000B41F8
		public int count
		{
			get
			{
				bool flag = this.m_Element.styleSheetList == null;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					num = this.m_Element.styleSheetList.Count;
				}
				return num;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		public StyleSheet this[int index]
		{
			get
			{
				bool flag = this.m_Element.styleSheetList == null;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return this.m_Element.styleSheetList[index];
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000B6070 File Offset: 0x000B4270
		public static bool operator ==(VisualElementStyleSheetSet left, VisualElementStyleSheetSet right)
		{
			return left.Equals(right);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000B608C File Offset: 0x000B428C
		public static bool operator !=(VisualElementStyleSheetSet left, VisualElementStyleSheetSet right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeFieldInfoPtr_m_Element;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_0;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_StyleSheet_0;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_StyleSheet_0;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisualElementStyleSheetSet_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
